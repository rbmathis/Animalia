using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Centriscidae.Notopogon;

/// <summary>
/// Abstract class for Notopogon (genus).
/// NCBI TaxId: 458591
/// </summary>
public abstract class Notopogon : Centriscidae, INotopogon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notopogon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 458591;

    /// <inheritdoc />
    public virtual string GenusName => "Notopogon";

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
