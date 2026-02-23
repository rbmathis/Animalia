using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Aphanotriccus;

/// <summary>
/// Abstract class for Aphanotriccus (genus).
/// NCBI TaxId: 183534
/// </summary>
public abstract class Aphanotriccus : Tyrannidae, IAphanotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphanotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183534;

    /// <inheritdoc />
    public virtual string GenusName => "Aphanotriccus";

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
