using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Celebesica;

/// <summary>
/// Abstract class for Celebesica (genus).
/// NCBI TaxId: 3240215
/// </summary>
public abstract class Celebesica : Campephagidae, ICelebesica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Celebesica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3240215;

    /// <inheritdoc />
    public virtual string GenusName => "Celebesica";

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
