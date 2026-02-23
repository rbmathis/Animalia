using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Sticharium;

/// <summary>
/// Abstract class for Sticharium (genus).
/// NCBI TaxId: 57859
/// </summary>
public abstract class Sticharium : Clinidae, ISticharium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sticharium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57859;

    /// <inheritdoc />
    public virtual string GenusName => "Sticharium";

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
