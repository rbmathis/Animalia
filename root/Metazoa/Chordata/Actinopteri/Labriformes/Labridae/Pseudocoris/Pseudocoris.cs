using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudocoris;

/// <summary>
/// Abstract class for Pseudocoris (genus).
/// NCBI TaxId: 241336
/// </summary>
public abstract class Pseudocoris : Labridae, IPseudocoris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocoris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241336;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocoris";

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
