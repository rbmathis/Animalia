using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Mollisquama;

/// <summary>
/// Abstract class for Mollisquama (genus).
/// NCBI TaxId: 3064077
/// </summary>
public abstract class Mollisquama : Dalatiidae, IMollisquama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mollisquama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3064077;

    /// <inheritdoc />
    public virtual string GenusName => "Mollisquama";

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
