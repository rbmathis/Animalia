using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Dalatias;

/// <summary>
/// Abstract class for Dalatias (genus).
/// NCBI TaxId: 170816
/// </summary>
public abstract class Dalatias : Dalatiidae, IDalatias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dalatias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170816;

    /// <inheritdoc />
    public virtual string GenusName => "Dalatias";

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
