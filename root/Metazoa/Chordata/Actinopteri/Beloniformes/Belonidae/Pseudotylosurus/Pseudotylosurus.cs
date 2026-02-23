using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Pseudotylosurus;

/// <summary>
/// Abstract class for Pseudotylosurus (genus).
/// NCBI TaxId: 106210
/// </summary>
public abstract class Pseudotylosurus : Belonidae, IPseudotylosurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudotylosurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106210;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudotylosurus";

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
