using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Ptychoramphus;

/// <summary>
/// Abstract class for Ptychoramphus (genus).
/// NCBI TaxId: 28705
/// </summary>
public abstract class Ptychoramphus : Alcidae, IPtychoramphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ptychoramphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28705;

    /// <inheritdoc />
    public virtual string GenusName => "Ptychoramphus";

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
