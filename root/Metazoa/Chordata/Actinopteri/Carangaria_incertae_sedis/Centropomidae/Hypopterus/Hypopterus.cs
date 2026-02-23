using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Centropomidae.Hypopterus;

/// <summary>
/// Abstract class for Hypopterus (genus).
/// NCBI TaxId: 2002839
/// </summary>
public abstract class Hypopterus : Centropomidae, IHypopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2002839;

    /// <inheritdoc />
    public virtual string GenusName => "Hypopterus";

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
