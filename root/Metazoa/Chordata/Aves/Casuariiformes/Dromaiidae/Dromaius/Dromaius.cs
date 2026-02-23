using AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae.Dromaius;

/// <summary>
/// Abstract class for Dromaius (genus).
/// NCBI TaxId: 8789
/// </summary>
public abstract class Dromaius : Dromaiidae, IDromaius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dromaius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8789;

    /// <inheritdoc />
    public virtual string GenusName => "Dromaius";

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
