using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Chacophrys;

/// <summary>
/// Abstract class for Chacophrys (genus).
/// NCBI TaxId: 377352
/// </summary>
public abstract class Chacophrys : Ceratophryidae, IChacophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chacophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377352;

    /// <inheritdoc />
    public virtual string GenusName => "Chacophrys";

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
