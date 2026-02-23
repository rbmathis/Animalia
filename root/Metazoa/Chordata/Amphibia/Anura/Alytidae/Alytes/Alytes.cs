using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alytidae.Alytes;

/// <summary>
/// Abstract class for Alytes (genus).
/// NCBI TaxId: 8442
/// </summary>
public abstract class Alytes : Alytidae, IAlytes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alytes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8442;

    /// <inheritdoc />
    public virtual string GenusName => "Alytes";

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
