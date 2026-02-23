using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Ailiichthys;

/// <summary>
/// Abstract class for Ailiichthys (genus).
/// NCBI TaxId: 3350523
/// </summary>
public abstract class Ailiichthys : Ailiidae, IAiliichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ailiichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3350523;

    /// <inheritdoc />
    public virtual string GenusName => "Ailiichthys";

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
