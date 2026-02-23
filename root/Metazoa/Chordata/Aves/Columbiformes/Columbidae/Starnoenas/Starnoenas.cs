using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Starnoenas;

/// <summary>
/// Abstract class for Starnoenas (genus).
/// NCBI TaxId: 2953439
/// </summary>
public abstract class Starnoenas : Columbidae, IStarnoenas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Starnoenas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2953439;

    /// <inheritdoc />
    public virtual string GenusName => "Starnoenas";

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
