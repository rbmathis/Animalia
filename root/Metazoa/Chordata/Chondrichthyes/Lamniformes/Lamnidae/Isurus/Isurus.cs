using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Isurus;

/// <summary>
/// Abstract class for Isurus (genus).
/// NCBI TaxId: 7845
/// </summary>
public abstract class Isurus : Lamnidae, IIsurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7845;

    /// <inheritdoc />
    public virtual string GenusName => "Isurus";

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
