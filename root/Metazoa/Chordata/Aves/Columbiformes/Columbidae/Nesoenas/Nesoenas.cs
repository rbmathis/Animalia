using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Nesoenas;

/// <summary>
/// Abstract class for Nesoenas (genus).
/// NCBI TaxId: 187125
/// </summary>
public abstract class Nesoenas : Columbidae, INesoenas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nesoenas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187125;

    /// <inheritdoc />
    public virtual string GenusName => "Nesoenas";

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
