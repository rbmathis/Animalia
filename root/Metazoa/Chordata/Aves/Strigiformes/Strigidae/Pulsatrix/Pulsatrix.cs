using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Pulsatrix;

/// <summary>
/// Abstract class for Pulsatrix (genus).
/// NCBI TaxId: 111819
/// </summary>
public abstract class Pulsatrix : Strigidae, IPulsatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pulsatrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111819;

    /// <inheritdoc />
    public virtual string GenusName => "Pulsatrix";

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
