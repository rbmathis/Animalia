using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pogonotriccus;

/// <summary>
/// Abstract class for Pogonotriccus (genus).
/// NCBI TaxId: 495249
/// </summary>
public abstract class Pogonotriccus : Tyrannidae, IPogonotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pogonotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495249;

    /// <inheritdoc />
    public virtual string GenusName => "Pogonotriccus";

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
