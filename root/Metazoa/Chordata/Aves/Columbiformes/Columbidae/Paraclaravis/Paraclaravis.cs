using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Paraclaravis;

/// <summary>
/// Abstract class for Paraclaravis (genus).
/// NCBI TaxId: 2953438
/// </summary>
public abstract class Paraclaravis : Columbidae, IParaclaravis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraclaravis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2953438;

    /// <inheritdoc />
    public virtual string GenusName => "Paraclaravis";

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
