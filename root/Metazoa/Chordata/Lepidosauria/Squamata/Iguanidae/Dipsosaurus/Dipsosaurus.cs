using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Dipsosaurus;

/// <summary>
/// Abstract class for Dipsosaurus (genus).
/// NCBI TaxId: 51216
/// </summary>
public abstract class Dipsosaurus : Iguanidae, IDipsosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipsosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51216;

    /// <inheritdoc />
    public virtual string GenusName => "Dipsosaurus";

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
