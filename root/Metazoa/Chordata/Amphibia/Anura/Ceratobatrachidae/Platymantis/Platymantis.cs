using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Platymantis;

/// <summary>
/// Abstract class for Platymantis (genus).
/// NCBI TaxId: 58511
/// </summary>
public abstract class Platymantis : Ceratobatrachidae, IPlatymantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platymantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 58511;

    /// <inheritdoc />
    public virtual string GenusName => "Platymantis";

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
