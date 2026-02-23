using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Artisornis;

/// <summary>
/// Abstract class for Artisornis (genus).
/// NCBI TaxId: 405072
/// </summary>
public abstract class Artisornis : Cisticolidae, IArtisornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Artisornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405072;

    /// <inheritdoc />
    public virtual string GenusName => "Artisornis";

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
