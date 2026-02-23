using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Laides;

/// <summary>
/// Abstract class for Laides (genus).
/// NCBI TaxId: 365584
/// </summary>
public abstract class Laides : Ailiidae, ILaides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365584;

    /// <inheritdoc />
    public virtual string GenusName => "Laides";

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
