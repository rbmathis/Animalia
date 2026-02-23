using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Cathartidae.Gymnogyps;

/// <summary>
/// Abstract class for Gymnogyps (genus).
/// NCBI TaxId: 33615
/// </summary>
public abstract class Gymnogyps : Cathartidae, IGymnogyps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnogyps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33615;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnogyps";

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
