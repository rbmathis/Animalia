using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Andropadus;

/// <summary>
/// Abstract class for Andropadus (genus).
/// NCBI TaxId: 59947
/// </summary>
public abstract class Andropadus : Pycnonotidae, IAndropadus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andropadus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 59947;

    /// <inheritdoc />
    public virtual string GenusName => "Andropadus";

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
