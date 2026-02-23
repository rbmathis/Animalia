using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Camaroptera;

/// <summary>
/// Abstract class for Camaroptera (genus).
/// NCBI TaxId: 98120
/// </summary>
public abstract class Camaroptera : Cisticolidae, ICamaroptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Camaroptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98120;

    /// <inheritdoc />
    public virtual string GenusName => "Camaroptera";

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
