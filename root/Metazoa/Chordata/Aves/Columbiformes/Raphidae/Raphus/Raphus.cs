using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Raphidae.Raphus;

/// <summary>
/// Abstract class for Raphus (genus).
/// NCBI TaxId: 187134
/// </summary>
public abstract class Raphus : Raphidae, IRaphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Raphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187134;

    /// <inheritdoc />
    public virtual string GenusName => "Raphus";

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
