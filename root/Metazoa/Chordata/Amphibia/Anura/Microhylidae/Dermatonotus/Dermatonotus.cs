using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Dermatonotus;

/// <summary>
/// Abstract class for Dermatonotus (genus).
/// NCBI TaxId: 143562
/// </summary>
public abstract class Dermatonotus : Microhylidae, IDermatonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermatonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143562;

    /// <inheritdoc />
    public virtual string GenusName => "Dermatonotus";

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
