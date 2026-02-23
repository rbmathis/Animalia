using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Formicariidae.Myrmothera;

/// <summary>
/// Abstract class for Myrmothera (genus).
/// NCBI TaxId: 117180
/// </summary>
public abstract class Myrmothera : Formicariidae, IMyrmothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrmothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117180;

    /// <inheritdoc />
    public virtual string GenusName => "Myrmothera";

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
