using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Cirrhitidae.Oxycirrhites;

/// <summary>
/// Abstract class for Oxycirrhites (genus).
/// NCBI TaxId: 587058
/// </summary>
public abstract class Oxycirrhites : Cirrhitidae, IOxycirrhites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxycirrhites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587058;

    /// <inheritdoc />
    public virtual string GenusName => "Oxycirrhites";

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
