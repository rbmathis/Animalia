using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Fistulariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathiformes_incertae_sedis.Fistulariidae.Fistularia;

/// <summary>
/// Abstract class for Fistularia (genus).
/// NCBI TaxId: 206153
/// </summary>
public abstract class Fistularia : Fistulariidae, IFistularia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fistularia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206153;

    /// <inheritdoc />
    public virtual string GenusName => "Fistularia";

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
