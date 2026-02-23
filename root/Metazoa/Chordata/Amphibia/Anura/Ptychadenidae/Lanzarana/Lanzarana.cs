using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ptychadenidae.Lanzarana;

/// <summary>
/// Abstract class for Lanzarana (genus).
/// NCBI TaxId: 685129
/// </summary>
public abstract class Lanzarana : Ptychadenidae, ILanzarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lanzarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685129;

    /// <inheritdoc />
    public virtual string GenusName => "Lanzarana";

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
