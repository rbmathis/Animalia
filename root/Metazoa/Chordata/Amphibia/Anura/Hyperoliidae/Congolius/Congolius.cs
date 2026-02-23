using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Congolius;

/// <summary>
/// Abstract class for Congolius (genus).
/// NCBI TaxId: 2829682
/// </summary>
public abstract class Congolius : Hyperoliidae, ICongolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2829682;

    /// <inheritdoc />
    public virtual string GenusName => "Congolius";

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
