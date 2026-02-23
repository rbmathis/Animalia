using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Liparidae.Allocareproctus;

/// <summary>
/// Abstract class for Allocareproctus (genus).
/// NCBI TaxId: 1696903
/// </summary>
public abstract class Allocareproctus : Liparidae, IAllocareproctus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allocareproctus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696903;

    /// <inheritdoc />
    public virtual string GenusName => "Allocareproctus";

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
