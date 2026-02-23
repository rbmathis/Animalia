using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudocheilinops;

/// <summary>
/// Abstract class for Pseudocheilinops (genus).
/// NCBI TaxId: 2986112
/// </summary>
public abstract class Pseudocheilinops : Labridae, IPseudocheilinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocheilinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2986112;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocheilinops";

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
