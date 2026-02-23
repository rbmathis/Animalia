using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Pseudepapterus;

/// <summary>
/// Abstract class for Pseudepapterus (genus).
/// NCBI TaxId: 1312661
/// </summary>
public abstract class Pseudepapterus : Auchenipteridae, IPseudepapterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudepapterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1312661;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudepapterus";

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
