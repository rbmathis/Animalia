using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Aplodinotus;

/// <summary>
/// Abstract class for Aplodinotus (genus).
/// NCBI TaxId: 225388
/// </summary>
public abstract class Aplodinotus : Sciaenidae, IAplodinotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aplodinotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 225388;

    /// <inheritdoc />
    public virtual string GenusName => "Aplodinotus";

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
