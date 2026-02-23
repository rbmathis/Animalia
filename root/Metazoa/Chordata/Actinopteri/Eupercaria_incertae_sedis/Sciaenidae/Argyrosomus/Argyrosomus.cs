using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Argyrosomus;

/// <summary>
/// Abstract class for Argyrosomus (genus).
/// NCBI TaxId: 172268
/// </summary>
public abstract class Argyrosomus : Sciaenidae, IArgyrosomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argyrosomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172268;

    /// <inheritdoc />
    public virtual string GenusName => "Argyrosomus";

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
