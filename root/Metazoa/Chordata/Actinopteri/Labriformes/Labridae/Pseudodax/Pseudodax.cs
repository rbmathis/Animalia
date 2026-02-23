using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudodax;

/// <summary>
/// Abstract class for Pseudodax (genus).
/// NCBI TaxId: 188118
/// </summary>
public abstract class Pseudodax : Labridae, IPseudodax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudodax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 188118;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudodax";

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
