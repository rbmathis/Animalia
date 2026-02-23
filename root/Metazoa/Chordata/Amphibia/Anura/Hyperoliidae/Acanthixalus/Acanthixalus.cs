using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Acanthixalus;

/// <summary>
/// Abstract class for Acanthixalus (genus).
/// NCBI TaxId: 143454
/// </summary>
public abstract class Acanthixalus : Hyperoliidae, IAcanthixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143454;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthixalus";

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
