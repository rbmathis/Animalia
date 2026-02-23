using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Calamonastes;

/// <summary>
/// Abstract class for Calamonastes (genus).
/// NCBI TaxId: 405074
/// </summary>
public abstract class Calamonastes : Cisticolidae, ICalamonastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calamonastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405074;

    /// <inheritdoc />
    public virtual string GenusName => "Calamonastes";

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
