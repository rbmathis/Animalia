using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bos;

/// <summary>
/// Abstract class for Bos (genus).
/// NCBI TaxId: 9903
/// </summary>
public abstract class Bos : Bovidae, IBos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9903;

    /// <inheritdoc />
    public virtual string GenusName => "Bos";

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
