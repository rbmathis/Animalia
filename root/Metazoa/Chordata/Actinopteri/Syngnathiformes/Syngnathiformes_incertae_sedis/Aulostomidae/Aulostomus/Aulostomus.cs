using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Aulostomidae.Aulostomus;

/// <summary>
/// Abstract class for Aulostomus (genus).
/// NCBI TaxId: 150447
/// </summary>
public abstract class Aulostomus : Aulostomidae, IAulostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 150447;

    /// <inheritdoc />
    public virtual string GenusName => "Aulostomus";

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
