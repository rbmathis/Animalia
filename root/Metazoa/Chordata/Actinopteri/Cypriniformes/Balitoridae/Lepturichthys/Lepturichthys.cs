using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Lepturichthys;

/// <summary>
/// Abstract class for Lepturichthys (genus).
/// NCBI TaxId: 172903
/// </summary>
public abstract class Lepturichthys : Balitoridae, ILepturichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepturichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172903;

    /// <inheritdoc />
    public virtual string GenusName => "Lepturichthys";

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
