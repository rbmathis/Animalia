using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tetranematichthys;

/// <summary>
/// Abstract class for Tetranematichthys (genus).
/// NCBI TaxId: 909889
/// </summary>
public abstract class Tetranematichthys : Auchenipteridae, ITetranematichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetranematichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909889;

    /// <inheritdoc />
    public virtual string GenusName => "Tetranematichthys";

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
