using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Dalatiidae.Isistius;

/// <summary>
/// Abstract class for Isistius (genus).
/// NCBI TaxId: 862897
/// </summary>
public abstract class Isistius : Dalatiidae, IIsistius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Isistius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 862897;

    /// <inheritdoc />
    public virtual string GenusName => "Isistius";

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
