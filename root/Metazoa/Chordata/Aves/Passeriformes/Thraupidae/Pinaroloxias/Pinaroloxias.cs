using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Pinaroloxias;

/// <summary>
/// Abstract class for Pinaroloxias (genus).
/// NCBI TaxId: 93069
/// </summary>
public abstract class Pinaroloxias : Thraupidae, IPinaroloxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinaroloxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 93069;

    /// <inheritdoc />
    public virtual string GenusName => "Pinaroloxias";

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
