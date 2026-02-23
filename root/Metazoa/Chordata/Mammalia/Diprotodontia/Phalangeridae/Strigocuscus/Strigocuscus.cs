using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Phalangeridae.Strigocuscus;

/// <summary>
/// Abstract class for Strigocuscus (genus).
/// NCBI TaxId: 293817
/// </summary>
public abstract class Strigocuscus : Phalangeridae, IStrigocuscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strigocuscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 293817;

    /// <inheritdoc />
    public virtual string GenusName => "Strigocuscus";

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
