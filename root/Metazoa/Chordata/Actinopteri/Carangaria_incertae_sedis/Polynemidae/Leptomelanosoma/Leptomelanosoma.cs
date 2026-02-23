using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Polynemidae.Leptomelanosoma;

/// <summary>
/// Abstract class for Leptomelanosoma (genus).
/// NCBI TaxId: 445389
/// </summary>
public abstract class Leptomelanosoma : Polynemidae, ILeptomelanosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptomelanosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 445389;

    /// <inheritdoc />
    public virtual string GenusName => "Leptomelanosoma";

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
