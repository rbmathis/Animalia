using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Turacoena;

/// <summary>
/// Abstract class for Turacoena (genus).
/// NCBI TaxId: 444150
/// </summary>
public abstract class Turacoena : Columbidae, ITuracoena
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turacoena";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 444150;

    /// <inheritdoc />
    public virtual string GenusName => "Turacoena";

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
