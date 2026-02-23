using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Hylomanes;

/// <summary>
/// Abstract class for Hylomanes (genus).
/// NCBI TaxId: 176944
/// </summary>
public abstract class Hylomanes : Momotidae, IHylomanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylomanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176944;

    /// <inheritdoc />
    public virtual string GenusName => "Hylomanes";

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
