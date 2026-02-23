using AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Peltocephalus;

/// <summary>
/// Abstract class for Peltocephalus (genus).
/// NCBI TaxId: 44523
/// </summary>
public abstract class Peltocephalus : Podocnemididae, IPeltocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peltocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44523;

    /// <inheritdoc />
    public virtual string GenusName => "Peltocephalus";

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
