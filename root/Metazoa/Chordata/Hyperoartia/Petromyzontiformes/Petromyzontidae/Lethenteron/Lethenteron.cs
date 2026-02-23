using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lethenteron;

/// <summary>
/// Abstract class for Lethenteron (genus).
/// NCBI TaxId: 94988
/// </summary>
public abstract class Lethenteron : Petromyzontidae, ILethenteron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lethenteron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94988;

    /// <inheritdoc />
    public virtual string GenusName => "Lethenteron";

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
