using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariidae_incertae_sedis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Loricariidae_incertae_sedis.Nannoplecostomus;

/// <summary>
/// Abstract class for Nannoplecostomus (genus).
/// NCBI TaxId: 2017758
/// </summary>
public abstract class Nannoplecostomus : Loricariidae_incertae_sedis, INannoplecostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nannoplecostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2017758;

    /// <inheritdoc />
    public virtual string GenusName => "Nannoplecostomus";

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
