using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Pedionomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Pedionomidae.Pedionomus;

/// <summary>
/// Abstract class for Pedionomus (genus).
/// NCBI TaxId: 227191
/// </summary>
public abstract class Pedionomus : Pedionomidae, IPedionomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pedionomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 227191;

    /// <inheritdoc />
    public virtual string GenusName => "Pedionomus";

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
