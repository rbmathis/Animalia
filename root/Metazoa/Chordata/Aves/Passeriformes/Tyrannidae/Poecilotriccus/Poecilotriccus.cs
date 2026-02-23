using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Poecilotriccus;

/// <summary>
/// Abstract class for Poecilotriccus (genus).
/// NCBI TaxId: 360242
/// </summary>
public abstract class Poecilotriccus : Tyrannidae, IPoecilotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poecilotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360242;

    /// <inheritdoc />
    public virtual string GenusName => "Poecilotriccus";

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
