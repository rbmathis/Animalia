using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Psilorhynchidae.Psilorhynchus;

/// <summary>
/// Abstract class for Psilorhynchus (genus).
/// NCBI TaxId: 327761
/// </summary>
public abstract class Psilorhynchus : Psilorhynchidae, IPsilorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psilorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 327761;

    /// <inheritdoc />
    public virtual string GenusName => "Psilorhynchus";

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
