using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rentapia;

/// <summary>
/// Abstract class for Rentapia (genus).
/// NCBI TaxId: 1933085
/// </summary>
public abstract class Rentapia : Bufonidae, IRentapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rentapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1933085;

    /// <inheritdoc />
    public virtual string GenusName => "Rentapia";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
