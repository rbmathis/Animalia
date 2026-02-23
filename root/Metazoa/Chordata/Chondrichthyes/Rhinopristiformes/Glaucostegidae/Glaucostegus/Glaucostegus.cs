using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Glaucostegidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Glaucostegidae.Glaucostegus;

/// <summary>
/// Abstract class for Glaucostegus (genus).
/// NCBI TaxId: 496013
/// </summary>
public abstract class Glaucostegus : Glaucostegidae, IGlaucostegus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glaucostegus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496013;

    /// <inheritdoc />
    public virtual string GenusName => "Glaucostegus";

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
