using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phenacorhamdia;

/// <summary>
/// Abstract class for Phenacorhamdia (genus).
/// NCBI TaxId: 1349274
/// </summary>
public abstract class Phenacorhamdia : Heptapteridae, IPhenacorhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacorhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1349274;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacorhamdia";

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
