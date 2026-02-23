using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Phlyctimantis;

/// <summary>
/// Abstract class for Phlyctimantis (genus).
/// NCBI TaxId: 356320
/// </summary>
public abstract class Phlyctimantis : Hyperoliidae, IPhlyctimantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phlyctimantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356320;

    /// <inheritdoc />
    public virtual string GenusName => "Phlyctimantis";

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
